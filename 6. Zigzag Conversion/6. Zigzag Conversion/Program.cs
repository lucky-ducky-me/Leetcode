string s = "A";
int numRows = 1;

int currentInd = 0;
var lines = new List<string>();

for (int i = 0; i < numRows; i++)
{
    lines.Add("");
}

while (currentInd < s.Length)
{
    var mod = s.Length - currentInd;

    if (mod < numRows)
    {
        for (int i = 0; i < mod; i++)
        {
            lines[i] += s[currentInd];
            currentInd++;
        }
    }
    else
    {
        for (int i = 0; i < numRows && currentInd < s.Length; i++)
        {
            lines[i] += s[currentInd];
            currentInd++;
        }

        for (int i = 1; i < numRows - 1 && currentInd < s.Length; i++)
        {
            lines[numRows - 1 - i] += s[currentInd];
            currentInd++;
        }
    }
}

string answer = "";

foreach (var line in lines)
{
    answer += line;
}

Console.WriteLine(answer);

