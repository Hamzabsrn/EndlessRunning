using System.Collections;
using System.Collections.Generic;
using Ultilities;
using UnityEngine;

namespace Managers
{
    public class GameManager : SingletonMonoBehaviourObejct<GameManager>
    {
        private void Awake()
        {
            SingletonThisObject(this);
        }
        public void StopGame()
        {
            Time.timeScale = 0;
        }
    
    
    
    
    
    
    
    }


}