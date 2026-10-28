





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
        Cheackvowel(word.ToLower());
    }
    catch (Exception err)
    {
        System.Console.WriteLine(err.Message);
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
void Cheackvowel(string vowel)
{
    bool status = false;



    for (int i = 0; i < vowel.Length; i++)
    {

        if (vowel[i] == 'a' || vowel[i] == 'e' || vowel[i] == 'i' || vowel[i] == 'o' || vowel[i] == 'u')
        {
            status = true;
            System.Console.WriteLine($"have some vowel {vowel[i]}");


        }
    }
    if (status == false)
    {
        throw new Exception("Not Found Any Vowel");
    }
}