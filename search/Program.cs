





using System.Xml.Serialization;

System.Console.WriteLine("Please Choose Your number 1 Or 2");
string choice = Console.ReadLine();
if (choice == "1")
{
    try
    {

        Number();
    }
    catch (Exception err)
    {
        System.Console.WriteLine(err.Message);
    }
}
if (choice == "2")
{
    try
    {
        System.Console.WriteLine("Enter Your Word");
        string word = Console.ReadLine();
        CheackTexts(word);
    }
    catch (Exception err)
    {

    }
}




void Number()
{
    System.Console.WriteLine("Please Enter Your num");
    List<int> num = new List<int>();
    int chooseNum1 = Convert.ToInt32(Console.ReadLine());
    num.Add(chooseNum1);
    System.Console.WriteLine("Please Enter Your num");
    int chooseNum2 = Convert.ToInt32(Console.ReadLine());
    num.Add(chooseNum2);
    System.Console.WriteLine("Please Enter Your num");
    int chooseNum3 = Convert.ToInt32(Console.ReadLine());
    num.Add(chooseNum3);
    System.Console.WriteLine("Please Enter Your num");
    int chooseNum4 = Convert.ToInt32(Console.ReadLine());
    num.Add(chooseNum4);
    for (int i = 0; i < num.Count; i++)
    {
        for (int j = 0; j < num.Count; j++)
        {
            if (i != j && num[i] == num[j])
            {

                throw new Exception("this number was dublicated" + " " + num[i]);
            }

        }
    }

}
void CheackTexts(string word)
{
    System.Console.WriteLine("Please Enter Your character");
    List<string> str = new List<string>();
    string choosestr1 = Console.ReadLine();
    str.Add(choosestr1);
    System.Console.WriteLine("Please Enter Your character");
    string choosestr2 = Console.ReadLine();
    str.Add(choosestr2);
    System.Console.WriteLine("Please Enter Your character");
    string chooseStr3 = Console.ReadLine();
    str.Add(chooseStr3);
    System.Console.WriteLine("Please Enter Your character");
    string chooseStr4 = Console.ReadLine();
    str.Add(chooseStr4);
    for (int i = 0; i < str.Count; i++)
    {
        for (int j = 0; j < str.Count; j++)
        {
            if (i != j && str[i] == str[j])
            {

                throw new Exception("this number was dublicated" + " " + str[i]);
            }

        }
    }
}