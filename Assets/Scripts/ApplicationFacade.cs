using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PureMVC.Patterns;

public class ApplicationFacade : Facade
{
    public ApplicationFacade(GameObject canvas)  
    {  
        RegisterCommand(NotificationConstant.LevelUp, typeof(CharacterCommand));  
        RegisterMediator(new CharacterMediator(canvas));  
        RegisterProxy(new CharacterProxy());  
    }  
}
