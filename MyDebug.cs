using UnityEngine;

namespace CustomDebug
{
    public class MyDebug
    {
        public static int ColorLength = 9;

        /// <summary>
        /// Muestra en consola con formato los mensajes para mayor legibilidad.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="message"></param>
        /// <param name="color"></param>
        public static void Log(string title, string message, int color)
        {
            color = Mathf.Clamp(color, 0, ColorLength);

            string colorString = "white";

            switch (color)
            {
                case 0:
                    colorString = "white";
                    break;
                case 1:
                    colorString = "#2EFF00";
                    break;
                case 2:
                    colorString = "#FFFB00";
                    break;
                case 3:
                    colorString = "#FF0000";
                    break;
                case 4:
                    colorString = "#FF00F7";
                    break;
                case 5:
                    colorString = "#C474FF";
                    break;
                case 6:
                    colorString = "#576EFF";
                    break;
                case 7:
                    colorString = "#3BD5FF";
                    break;
                case 8:
                    colorString = "#3BFFBE";
                    break;
            }

            string colorOpen = $"<color={colorString}>";

            Debug.Log($"<b>{colorOpen}[{title}]</color></b> {message}");
        }
    }

}