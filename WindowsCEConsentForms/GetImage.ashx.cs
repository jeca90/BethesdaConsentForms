﻿using System;
using System.Configuration;
using System.Drawing.Imaging;
using System.ServiceModel;
using System.Web;
using System.Web.Configuration;
using WindowsCEConsentForms.FormHandlerService;

namespace WindowsCEConsentForms
{
    /// <summary>
    /// Summary description for GetImage
    /// </summary>
    public class GetImage : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            string patientId;
            try
            {
                patientId = context.Request.QueryString["PatientID"];
            }
            catch (Exception)
            {
                patientId = string.Empty;
            }
            if (!string.IsNullOrEmpty(patientId))
            {
                string signatureId;
                try
                {
                    signatureId = context.Request.QueryString["Signature"];
                }
                catch (Exception)
                {
                    signatureId = string.Empty;
                }
                if (!string.IsNullOrEmpty(signatureId))
                {
                    string consentType;
                    try
                    {
                        consentType = context.Request.QueryString["ConsentType"];
                    }
                    catch (Exception)
                    {
                        consentType = string.Empty;
                    }
                    if (string.IsNullOrEmpty(consentType))
                        return;
                    var formHandlerServiceClient = Utilities.GetConsentFormSvcClient();
                    var content = formHandlerServiceClient.GetPatientSignature(patientId, (ConsentType)Enum.Parse(typeof(ConsentType), consentType), (SignatureType)Enum.Parse(typeof(SignatureType), signatureId));
                    var signatureToImage = new SignatureToImage();
                    var bitmap = signatureToImage.SigJsonToImage(content);
                    bitmap.Save(context.Response.OutputStream, ImageFormat.Jpeg);
                }
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}