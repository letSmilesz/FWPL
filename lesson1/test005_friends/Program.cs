int count = 0;
int distanse = 10000;
int firstFriensSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 6;
int friend = 2;
int time = 0;

while (distanse > 10)
{
    if (friend == 1)
    {
        time = distanse/(firstFriensSpeed+dogSpeed);
        friend = 2;
    }
    else
    {
        time = distanse/(secondFriendSpeed+dogSpeed);
        friend = 1;
    }
    distanse = distanse - (firstFriensSpeed + secondFriendSpeed) * time;
    count += 1;
}
Console.WriteLine (count);