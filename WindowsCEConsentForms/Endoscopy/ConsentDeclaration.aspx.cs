﻿using System;
using System.Text;
using System.Web.UI;
using WindowsCEConsentForms.ConsentFormsService;

namespace WindowsCEConsentForms.Endoscopy
{
    public partial class ConsentDeclaration1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DeclarationSignatures.BtnCompleted.Click += BtnCompleted_Click;
            DeclarationSignatures.BtnReset.Click += BtnReset_Click;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            DoctorsAndProcedures1.DdLProcedures.SelectedIndex = 0;
            DoctorsAndProcedures1.LblAssociatedDoctors.Text = string.Empty;
            DoctorsAndProcedures1.DdlPrimaryDoctors.SelectedIndex = 0;
            DoctorsAndProcedures1.HdnSelectedProcedures.Value = string.Empty;

            ConsentSignatures.ResetSignatures();

            DeclarationSignatures.ResetSignatures();
            DeclarationSignatures.ChkPatientisUnableToSign.Checked = false;
            DeclarationSignatures.SetPanels(false);
        }

        protected void BtnCompleted_Click(object sender, EventArgs e)
        {
            try
            {
                const ConsentType consentType = ConsentType.Endoscopy;

                //validation
                var lblError = DeclarationSignatures.LblError;
                var chkPatientisUnableToSign = DeclarationSignatures.ChkPatientisUnableToSign;
                var txtPatientNotSignedBecause = DeclarationSignatures.TxtPatientNotSignedBecause;

                lblError.Text = string.Empty;

                if (string.IsNullOrEmpty(Request.Form[SignatureType.DoctorSign1.ToString()]) ||
                   string.IsNullOrEmpty(Request.Form[SignatureType.DoctorSign2.ToString()]) ||
                   string.IsNullOrEmpty(Request.Form[SignatureType.DoctorSign3.ToString()]) ||
                   string.IsNullOrEmpty(Request.Form[SignatureType.DoctorSign4.ToString()]) ||
                   string.IsNullOrEmpty(Request.Form[SignatureType.DoctorSign5.ToString()]))
                {
                    lblError.Text = "Please input signatures.";
                }

                if (chkPatientisUnableToSign.Checked)
                {
                    if (string.IsNullOrEmpty(txtPatientNotSignedBecause.Text.Trim()))
                        lblError.Text += " <br /> Please input reason for why patient not able sign.";

                    if (string.IsNullOrEmpty(Request.Form[SignatureType.PatientAuthorizeSign.ToString()]))
                        lblError.Text += " <br /> Please input patient authorized person signature.";
                }
                else
                {
                    if (string.IsNullOrEmpty(Request.Form[SignatureType.PatientSign.ToString()]))
                        lblError.Text += " <br /> Please input patient  signature.";
                }

                if (string.IsNullOrEmpty(Request.Form[SignatureType.WitnessSignature1.ToString()]))
                    lblError.Text += " <br /> Please input witness signature.";

                if (DeclarationSignatures.ChkTelephoneConsent.Checked && string.IsNullOrEmpty(Request.Form[SignatureType.WitnessSignature1.ToString()]))
                    lblError.Text += " <br /> Please input witness 2 signature.";

                if (!string.IsNullOrEmpty(lblError.Text))
                {
                    return;
                }

                string patientId = string.Empty;
                try
                {
                    patientId = Session["PatientID"].ToString();
                }
                catch (Exception)
                {
                    Response.Redirect("/PatientConsent.aspx");
                }

                string selectedProcedurenames = string.Empty;

                // validation for other procedure
                foreach (string procedurename in DoctorsAndProcedures1.HdnSelectedProcedures.Value.Split('#'))
                {
                    if (!string.IsNullOrEmpty(procedurename))
                    {
                        if (procedurename.Trim().ToLower() == "other")
                        {
                            if (string.IsNullOrEmpty(DoctorsAndProcedures1.TxtOtherProcedure.Text))
                            {
                                lblError.Text = "Please input your signatures in all the fields";
                                return;
                            }
                            selectedProcedurenames += DoctorsAndProcedures1.TxtOtherProcedure.Text;
                        }
                        else
                            selectedProcedurenames += procedurename + "#";
                    }
                }

                var formHandlerServiceClient = new FormHandlerServiceClient();

                formHandlerServiceClient.UpdateDoctorAssociation(patientId, DoctorsAndProcedures1.DdlPrimaryDoctors.SelectedValue, DoctorsAndProcedures1.LblAssociatedDoctors.Text, consentType.ToString());

                formHandlerServiceClient.UpdatePatientProcedures(patientId, selectedProcedurenames, consentType.ToString());

                if (Request.Form[SignatureType.DoctorSign1.ToString()] != null)
                {
                    var bytes = Encoding.ASCII.GetBytes(Request.Form[SignatureType.DoctorSign1.ToString()]);
                    bool result = formHandlerServiceClient.SavePatientSignature(patientId, Encoding.ASCII.GetString(bytes), consentType.ToString(), SignatureType.DoctorSign1.ToString());
                }

                if (Request.Form[SignatureType.DoctorSign2.ToString()] != null)
                {
                    var bytes = Encoding.ASCII.GetBytes(Request.Form[SignatureType.DoctorSign2.ToString()]);
                    var result = formHandlerServiceClient.SavePatientSignature(patientId, Encoding.ASCII.GetString(bytes), consentType.ToString(), SignatureType.DoctorSign2.ToString());
                }

                if (Request.Form[SignatureType.DoctorSign3.ToString()] != null)
                {
                    var bytes = Encoding.ASCII.GetBytes(Request.Form[SignatureType.DoctorSign3.ToString()]);
                    var result = formHandlerServiceClient.SavePatientSignature(patientId, Encoding.ASCII.GetString(bytes), consentType.ToString(), SignatureType.DoctorSign3.ToString());
                }

                if (Request.Form[SignatureType.DoctorSign4.ToString()] != null)
                {
                    var bytes = Encoding.ASCII.GetBytes(Request.Form[SignatureType.DoctorSign4.ToString()]);
                    var result = formHandlerServiceClient.SavePatientSignature(patientId, Encoding.ASCII.GetString(bytes), consentType.ToString(), SignatureType.DoctorSign4.ToString());
                }

                if (Request.Form[SignatureType.DoctorSign5.ToString()] != null)
                {
                    var bytes = Encoding.ASCII.GetBytes(Request.Form[SignatureType.DoctorSign5.ToString()]);
                    var result = formHandlerServiceClient.SavePatientSignature(patientId, Encoding.ASCII.GetString(bytes), consentType.ToString(), SignatureType.DoctorSign5.ToString());
                }

                if (Request.Form[SignatureType.PatientSign.ToString()] != null)
                {
                    var bytes = Encoding.ASCII.GetBytes(Request.Form[SignatureType.PatientSign.ToString()]);
                    var result = formHandlerServiceClient.SavePatientSignature(patientId, Encoding.ASCII.GetString(bytes), consentType.ToString(), SignatureType.PatientSign.ToString());
                }

                if (Request.Form[SignatureType.PatientAuthorizeSign.ToString()] != null)
                {
                    var bytes = Encoding.ASCII.GetBytes(Request.Form[SignatureType.PatientAuthorizeSign.ToString()]); // Patient Signature
                    var result = formHandlerServiceClient.SavePatientSignature(patientId, Encoding.ASCII.GetString(bytes), consentType.ToString(), SignatureType.PatientAuthorizeSign.ToString());
                }

                if (Request.Form[SignatureType.TranslatedBySign.ToString()] != null)
                {
                    // updating signature4
                    var bytes = Encoding.ASCII.GetBytes(Request.Form[SignatureType.TranslatedBySign.ToString()]); // Translated by (name & empl.#)
                    var result = formHandlerServiceClient.SavePatientSignature(patientId, Encoding.ASCII.GetString(bytes), consentType.ToString(), SignatureType.TranslatedBySign.ToString());
                }

                // updating signature5
                if (Request.Form[SignatureType.WitnessSignature1.ToString()] != null)
                {
                    var bytes = Encoding.ASCII.GetBytes(Request.Form[SignatureType.WitnessSignature1.ToString()]);
                    var result = formHandlerServiceClient.SavePatientSignature(patientId, Encoding.ASCII.GetString(bytes), consentType.ToString(), SignatureType.WitnessSignature1.ToString());
                }

                // updating signature6
                if (Request.Form[SignatureType.WitnessSignature2.ToString()] != null)
                {
                    var bytes = Encoding.ASCII.GetBytes(Request.Form[SignatureType.WitnessSignature2.ToString()]);
                    var result = formHandlerServiceClient.SavePatientSignature(patientId, Encoding.ASCII.GetString(bytes), consentType.ToString(), SignatureType.WitnessSignature2.ToString());
                }

                string ip = Request.ServerVariables["REMOTE_ADDR"];
                string device;
                if (Request.Browser.IsMobileDevice)
                    device = Request.Browser.Browser + " " + Request.Browser.Version;
                else
                    device = Request.Browser.Browser + " " + Request.Browser.Version;

                formHandlerServiceClient.UpdateTrackingInfo(patientId, new TrackingInfo { IP = ip, Device = device });

                formHandlerServiceClient.UpdatePatientUnableSignReason(patientId, chkPatientisUnableToSign.Checked ? txtPatientNotSignedBecause.Text : string.Empty);

                Utilities.GeneratePdfAndUploadToSharePointSite(formHandlerServiceClient, consentType, patientId);

                Response.Redirect(Utilities.GetNextFormUrl(consentType, Session));
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}