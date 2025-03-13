//Console.WriteLine(numbers[1,1]);

//int[,] numbers = new int[2, 3];


//// int [n, m]

//numbers[0, 0] = 1;
//numbers[0, 1] = 2;
//numbers[0, 2] = 3;
//numbers[1, 0] = 4;
//numbers[1, 1] = 5;
//numbers[1, 2] = 6;

//Console.WriteLine();

//int m = 5;
//int n = 6;

//int[,] multArr = new int[m, n];

//int num = 1;
//int sum = 0;

////{ 1, 2, 3, 4, 5, 6 }
//for (int i = 0; i < m; i++)
//{
//    // m - meramdene array a (m+1)
//    for (int j = 0; j < n; j++)
//    {
//        // n - wevrebis rigitoba
//        multArr[i, j] = num; // 0,0  0,1  0,2
//        Console.Write(multArr[i, j] + " ");
//        sum += num;
//        num++;
//    }
//    Console.WriteLine();
//}

//Console.WriteLine(sum);

//Random random = new Random();

//int m = 2;
//int n = 2;
//int sum = 0;

//int[,] multArr = new int[2, 2];

//for (int i = 0; i <= m; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        int num = random.Next(1, 101);
//        multArr[i, j] = num;
//        sum += num;
//        Console.Write(multArr[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine(sum);

//int[,] numbers1 = new int[2, 3]
//{
//    { 1,2,3 }, //0
//    { 4,5,6 } //1
//};

//int sum1 = GetSum(numbers1);
//Console.WriteLine($"sum1: {sum1}");


//int[,] numbers2 = new int[4, 5]
//{
//    { 1, 1, 1, 1, 1 }, 
//    { 1, 1, 1, 1, 1 },
//    { 1, 1, 1, 1, 1 }, 
//    { 1, 1, 1, 1, 1 }
//};

//int sum2 = GetSum(numbers2);
//Console.WriteLine($"sum2: {sum2}");

//int[,,] numbers3 = new int[2,2,2]
//{
//    { 
//        {1, 1}, 
//        {1, 1} 
//    },
//    { 
//        {1, 1}, 
//        {1, 1} 
//    }
//};

//int GetSum(int[,] nums)
//{
//    int sum = 0;

//    int legth0 = nums.GetLength(0);  // 2
//    int legth1 = nums.GetLength(1);  // 3

//    for (int i = 0; i < legth0; i++)
//    {
//        for (int j = 0; j < legth1; j++)
//        {
//            sum += nums[i,j];
//        }
//    }

//    return sum;
//}

string[,] multArr = new string[4, 4];

Random random = new Random();

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        int num = random.Next(0,2);
        multArr[i, j] = num == 1 ? "X" : "O";
        Console.Write(multArr[i, j] + " ");
    }
    Console.WriteLine();
}


//string[,] XOArr = new string[3, 3];

string result = CheckWinner(multArr);

Console.WriteLine(result);
string? CheckWinner(string[,] gameArr)
{
    int n = gameArr.GetLength(0);  // 3X3

    bool hasWinner = true;
    string first = gameArr[0, 0];
    for (int i = 1; i < n; i++)
    {
        if (first != gameArr[i, i]) hasWinner = false;
    }
    if (hasWinner) return first;

    hasWinner = true;
    string last = gameArr[0, n];  // 0,2
    for (int i = 1; i < n; i++)
    {
        // [1, 1]   [2, 0]
        if (first != gameArr[i, n - i - 1]) return null;
    }

    for (int i = 0; i < n; i++)
    {

    }

    if (gameArr[0, 0] == gameArr[0, 1] && gameArr[0, 0] == gameArr[0, 2]) return gameArr[0, 0];
    if (gameArr[1, 0] == gameArr[1, 1] && gameArr[1, 0] == gameArr[1, 2]) return gameArr[1, 0];
    if (gameArr[2, 0] == gameArr[2, 1] && gameArr[2, 0] == gameArr[2, 2]) return gameArr[2, 0];

    if (gameArr[0, 0] == gameArr[1, 0] && gameArr[0, 0] == gameArr[2, 0]) return gameArr[0, 0];
    if (gameArr[0, 1] == gameArr[1, 1] && gameArr[0, 1] == gameArr[2, 1]) return gameArr[0, 1];
    if (gameArr[0, 2] == gameArr[1, 2] && gameArr[0, 2] == gameArr[2, 2]) return gameArr[0, 2];

    if (gameArr[0, 0] == gameArr[1, 1] && gameArr[0, 0] == gameArr[2, 2]) return gameArr[0, 0];
    if (gameArr[0, 2] == gameArr[1, 1] && gameArr[0, 2] == gameArr[2, 0]) return gameArr[0, 2];

    return null;
}
















