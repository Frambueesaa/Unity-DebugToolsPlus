using UnityEngine;

namespace CustomDebug
{
    public class MyDebug
    {
        public static int ColorLength = 9;

        /// <summary>
        /// Obtiene el string para el color.
        /// </summary>
        /// <returns></returns>
        static string GetColorString(int color)
        {
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

            return colorString;
        }

        /// <summary>
        /// Muestra en consola con formato los mensajes para mayor legibilidad.
        /// </summary>
        /// <param name="title"> Titulo del mensaje </param>
        /// <param name="message"> Contenido del mensaje </param>
        /// <param name="color"> Codigo de color del mensaje (0 - ColorLength) </param>
        public static void Log(string title, string message, int color)
        {
            color = Mathf.Clamp(color, 0, ColorLength);
            string colorOpen = $"<color={GetColorString(color)}>";
            Debug.Log($"<b>{colorOpen}[{title}]</color></b> {message}");
        }

        /// <summary>
        /// Muestra en consola con formato los mensajes resaltando un objeto junto a este.
        /// </summary>
        /// <param name="title"> Titulo del mensaje </param>
        /// <param name="message"> Contenido del mensaje </param>
        /// <param name="contextObj"> Objeto para resaltar en el mensaje </param>
        /// <param name="color"> Codigo de color del mensaje (0 - ColorLength) </param>
        public static void Log(string title, string message, Object contextObj, int color)
        {
            color = Mathf.Clamp(color, 0, ColorLength);
            string colorOpen = $"<color={GetColorString(color)}>";
            Debug.Log($"<b>{colorOpen}[{title}]</color></b> {message}", contextObj);
        }

        /// <summary>
        /// Muestra en consola con formato los mensajes para mayor legibilidad pudiendo
        /// cambiar el tipo de mensaje por aviso o error.
        /// </summary>
        /// <param name="title"> Titulo del mensaje </param>
        /// <param name="message"> Contenido del mensaje </param>
        /// <param name="color"> Codigo de color del mensaje (0 - ColorLength) </param>
        /// <param name="debugType"> Cambia el mensaje del Log por advertencia o error. </param>
        public static void Log(string title, string message, int color, DebugType debugType)
        {
            color = Mathf.Clamp(color, 0, ColorLength);
            string colorOpen = $"<color={GetColorString(color)}>";

            switch (debugType)
            {
                case DebugType.NORMAL:
                    Debug.Log($"<b>{colorOpen}[{title}]</color></b> {message}");
                    break;
                case DebugType.WARN:
                    Debug.LogWarning($"<b>{colorOpen}[{title}]</color></b> {message}");
                    break;
                case DebugType.ERROR:
                    Debug.LogError($"<b>{colorOpen}[{title}]</color></b> {message}");
                    break;
            }
        }

        /// <summary>
        /// Muestra en consola con formato los mensajes para mayor legibilidad pudiendo
        /// cambiar el tipo de mensaje por aviso o error.
        /// </summary>
        /// <param name="title"> Titulo del mensaje </param>
        /// <param name="message"> Contenido del mensaje </param>
        /// <param name="color"> Codigo de color del mensaje (0 - ColorLength) </param>
        /// <param name="debugType"> Cambia el mensaje del Log por advertencia o error. </param>
        public static void Log(string title, string message, Object contextObj, int color, DebugType debugType)
        {
            color = Mathf.Clamp(color, 0, ColorLength);
            string colorOpen = $"<color={GetColorString(color)}>";

            switch (debugType)
            {
                case DebugType.NORMAL:
                    Debug.Log($"<b>{colorOpen}[{title}]</color></b> {message}", contextObj);
                    break;
                case DebugType.WARN:
                    Debug.LogWarning($"<b>{colorOpen}[{title}]</color></b> {message}", contextObj);
                    break;
                case DebugType.ERROR:
                    Debug.LogError($"<b>{colorOpen}[{title}]</color></b> {message}", contextObj);
                    break;
            }
        }
    }
}