/*
Task: Istifadəçi console-dan istədiyi qədər ədəd daxil edəcək (Exceptionun qarşısını alırsınız), 
hər daxil edilən ədəddən sonra ədəd daxil etmək istəyib istəməməsi sualı ekrana yazılacaq. Y,y daxil edilərsə, 
yeni bir ədəd daxil edəcək, fərqli nəsə daxil edərsə, əvvəldən yazdığınız ədədlərdən tək ədəd olanlar 
içərisində ən böyük və ən kiçik ədədi bir birindən çıxıb ekrana yazdırmaq.
 */


int num;
int[] arr = { };
bool check = true;
int[] newArr = { };
do
{

    Console.WriteLine("Bir eded daxil edin: ");
    string numStr = Console.ReadLine();
    while (!int.TryParse(numStr,out num))
    {
        Console.WriteLine("Ededi duzgun daxil edin: ");
        numStr = Console.ReadLine();
    }
    Array.Resize(ref arr, arr.Length+1);
    arr[arr.Length-1] = num;

    Console.WriteLine("Yeni bir eded daxil etmek isteyirsiniz? ");
    string answer = Console.ReadLine();
    if(!(answer.ToUpper().Trim() == "Y"))
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 1)
            {
                Array.Resize(ref newArr, newArr.Length+1);
                newArr[newArr.Length-1] = arr[i];
            }
        }

        Array.Sort(newArr);

        Console.WriteLine(newArr[newArr.Length-1] - newArr[0]);
        check = false;
    }


} while (check);
