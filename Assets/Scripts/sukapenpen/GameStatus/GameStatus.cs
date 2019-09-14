using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameStatus
{
   public float elapsedTime { get; protected set; }
      
   public abstract GameStatus Run(float _time, int _doors, GameObject _player);

   public abstract GameStatus NextEx();
}
