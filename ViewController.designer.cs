// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace RealBMICalc
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel BMILable { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CalculateButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField HeightTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField WeightTextField { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (BMILable != null) {
                BMILable.Dispose ();
                BMILable = null;
            }

            if (CalculateButton != null) {
                CalculateButton.Dispose ();
                CalculateButton = null;
            }

            if (HeightTextField != null) {
                HeightTextField.Dispose ();
                HeightTextField = null;
            }

            if (WeightTextField != null) {
                WeightTextField.Dispose ();
                WeightTextField = null;
            }
        }
    }
}