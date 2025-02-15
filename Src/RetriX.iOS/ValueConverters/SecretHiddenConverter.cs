﻿using Foundation;
using MvvmCross.Converters;
using RetriX.Shared.ViewModels;
using System;
using System.Globalization;

namespace RetriX.iOS.ValueConverters
{
    public class SecretHiddenConverter : MvxValueConverter<DisplayGeneratorViewModel, string>
    {
        protected override string Convert(DisplayGeneratorViewModel value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.AllowExporting ? value.SecretBase32 : NSBundle.MainBundle.GetLocalizedString("NotExportable", string.Empty);
        } 
    }
}
