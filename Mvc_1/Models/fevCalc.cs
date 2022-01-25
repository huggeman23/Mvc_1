namespace Mvc_1.Models
{
    public class fevCalc
    {
        public int teprature { get; set; }
        public string message { get; set; }
        public fevCalc(int temp)
        {
            teprature = temp;
            message = tempCalc(temp);
        }
        public static string tempCalc(int teprature) {
            
                if (teprature >= 38)
                {
                    return "you have fever";

                }
                else if (teprature == 0)
                {
                    return "";
                }
                else if (teprature <= 35)
                {
                    return "you have hypothermia";
                }               
                else
                {
                    return "you are fine";
                }
            
        }
    }
}
