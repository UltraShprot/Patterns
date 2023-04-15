using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashAnimation 
{
    protected HashAnimation hashAnimation;

    public int idle { get => Animator.StringToHash("idlee"); }
    public int pick { get => Animator.StringToHash("enabled"); }
    public int rotate { get => Animator.StringToHash("rotate"); }
    public int position { get => Animator.StringToHash("position"); }
}
