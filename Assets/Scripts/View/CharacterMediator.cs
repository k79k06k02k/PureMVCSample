using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns;
using UnityEngine.UI;
using PureMVC.Interfaces;

public class CharacterMediator : Mediator
{
    public new const string NAME = "CharacterMediator";

    private Text levelText;
    private Button levelUpButton;

    public CharacterMediator(GameObject root) : base(NAME)
    {  
        //levelText = GameUtility.GetChildComponent(root, "Text/LevelText");  
        //levelUpButton = GameUtility.GetChildComponent(root, "LevelUpButton");  

        levelUpButton.onClick.AddListener(OnClickLevelUpButton);  
    }

    private void OnClickLevelUpButton()
    {  
        SendNotification(NotificationConstant.LevelUp);  
    }

    public override IList<string> ListNotificationInterests()
    {  
        IList<string> list = new List<string>();  
        list.Add(NotificationConstant.LevelChange);  
        return list;  
    }

    public override void HandleNotification(INotification notification)
    {  
        switch(notification.Name)
        {  
        case NotificationConstant.LevelChange:  
            CharacterProxy.CharacterInfo ci = notification.Body as CharacterProxy.CharacterInfo;  
            //levelText.text = ci.Level.ToString();  
            break;  
        default :  
            break;  
        }  

    }
}
