// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace RetriX.iOS
{
    [Register ("AddGeneratorView")]
    partial class AddGeneratorView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch AllowExportingToggle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField IssuerTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField LabelTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField SecretTextField { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (AllowExportingToggle != null) {
                AllowExportingToggle.Dispose ();
                AllowExportingToggle = null;
            }

            if (IssuerTextField != null) {
                IssuerTextField.Dispose ();
                IssuerTextField = null;
            }

            if (LabelTextField != null) {
                LabelTextField.Dispose ();
                LabelTextField = null;
            }

            if (SecretTextField != null) {
                SecretTextField.Dispose ();
                SecretTextField = null;
            }
        }
    }
}