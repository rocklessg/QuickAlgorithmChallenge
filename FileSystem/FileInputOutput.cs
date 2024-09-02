namespace FileSystem
{
    public static class FileInputOutput
    {
        public static void ReadFromFile()
        {
            StreamWriter writer = new("test.txt");
            writer.WriteLine("I see no changes \n wake up in the morning and I ask myself \n is life worth living should I blast myself");
            writer.Close();

            StreamReader reader = new("Test.txt");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string line = reader.ReadToEnd();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            Console.WriteLine(line);
            reader.Close();
        }
    }

    enum SeaState
    {
        EmptySea,
        Attacked,
        Battleship,
        Cruiser
            //SeaState seaState;
            //seaState = SeaState.EmptySea;
            //var openSea = SeaState.EmptySea;
            //openSea.CompareTo(SeaState.EmptySea);
    }
}
