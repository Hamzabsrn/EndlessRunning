using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Input
{
    public interface ReaderIInput 
    {
       float Horizontal { get;}
       bool IsJump { get; }
    }

}