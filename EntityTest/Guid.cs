namespace EntityTest
{
    public class Guid
    {
        private static uint currentId = 0;
        public static uint GetId => currentId++;
    }
}
