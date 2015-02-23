for (int index = 0; index < input.Length; index += 8)
{
    string characterBinary = input.Substring(index, 8);
    char character = (char)Convert.ToInt32(characterBinary, 2);
    Console.Write(character);
}