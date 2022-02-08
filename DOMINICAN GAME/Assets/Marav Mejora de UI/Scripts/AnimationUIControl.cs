using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationUIControl : MonoBehaviour
{
    public Animator animator;

    public void playAnimacion(string nombre) {
        animator.Play(nombre, 0);
    }

    public void playAnimacionFade(string nombre)
    {
        animator.CrossFade(nombre, 0);
    }


}
