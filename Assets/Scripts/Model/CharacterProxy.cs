using PureMVC.Patterns;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterProxy : Proxy
{
    public class CharacterInfo
    {
        public int level;
        public int hp;

        public CharacterInfo()
        {
        }

        public CharacterInfo(int level, int hp)
        {
            this.level = level;
            this.hp = hp;
        }
    }


    public new const string NAME = "CharacterProxy";
    public CharacterInfo Data { get; set; }

    public CharacterProxy() : base(NAME)  
    {
        Data = new CharacterInfo();
    }

    public void ChangeLevel(int change)
    {
        Data.level += change;
        SendNotification(NotificationConstant.LevelChange, Data);
    }
}
