namespace Mvc_1.Models
{
    public class numCheck
    {
        public string numValid(int number, int num)
        {

             if (number > num)
            {
                return "To heigh";
            }
            else if (number < num)
            {
                return "To low";
            }
            else
            {
                return "Corect can you gues the next one";
            }

        }
    }
}
