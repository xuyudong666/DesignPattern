using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.States;

public class SecondaryState(User user) : LevelState(user)
{
    public override void Defeat()
    {
        Console.WriteLine("熟练级用户输了，扣20分");
        User.Score -= 20;
    }

    public override void Play()
    {
        Console.WriteLine("熟练级用户开始游戏");
    }

    public override void Win()
    {
        Console.WriteLine("熟练级用户胜利，赢20分触发加倍");
        User.Score += 30;
    }
}
