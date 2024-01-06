using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

public class CharacterEvents
{
    //Player nhan sat thuong va gia tri sat thuong 
    public static UnityAction<GameObject, int> characterDamaged;


    //Player hoi mau va gia tri mau duoc hoi
    public static UnityAction<GameObject, int> characterHealed;
}