// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool[] array = { false, true };

bool x = array[0];

bool y = array[0];

bool result = false;

for (int i = 0; i <= array.Length; i++)
{
    for (int j = 0; j <= array.Length; j++)
    {
        if ((!(array[i] | array[j])) == ((!array[i]) & (!array[j])))
        {
            Console.WriteLine("statment is true");
        }
        else
        {
            Console.WriteLine("statment is false");
            break;
        }
    }
}



