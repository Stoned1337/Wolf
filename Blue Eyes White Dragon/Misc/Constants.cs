﻿using System;

namespace Blue_Eyes_White_Dragon.Misc
{
    public static class Constants
    {
        public static string Jpg => Enum.GetName(typeof(Constants.SupportedImageType), Constants.SupportedImageType.jpg);
        public static string Png => Enum.GetName(typeof(Constants.SupportedImageType), Constants.SupportedImageType.png);
        public static string CardsFolderName = "cardcropHD400.jpg.zib Unpacked";
        public static string CardsDlcFolderName = "cardcropHD401.jpg.zib Unpacked";
        public static string ResourceFolderName = "Resources";
        public static string OutputFolderName = "Output";
        public static string PendulumFolderName = "Pendulums";
        public static string ResourceOutputFolderName = $"{ResourceFolderName}\\{OutputFolderName}";
        public static string ResourcePendulumLocation = $"{ResourceFolderName}\\{PendulumFolderName}";
        public static string ErrorImageName = "error.bmp";
        public static string ArtworkMatchFileName = "ArtworkMatch.json";

        public static int ConsoleLimit = 20000;
        public static readonly string StringError = "Internal Error";

        public enum SupportedImageType
        {
            jpg,
            png,
        }

        public enum Setting
        {
            LastUsedLoadPath,
            LastUsedReplacementImagePath,
            LastUsedCardDbPath
        }
    }
}
