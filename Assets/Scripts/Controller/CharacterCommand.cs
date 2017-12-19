using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns;
using PureMVC.Interfaces;

public class CharacterCommand : SimpleCommand
{
    public new const string NAME = "CharacterCommand";  

    public override void Execute(INotification notification)  
    {  
        CharacterProxy proxy = (CharacterProxy)Facade.RetrieveProxy(CharacterProxy.NAME);  
        proxy.ChangeLevel(1);
    }  

}
