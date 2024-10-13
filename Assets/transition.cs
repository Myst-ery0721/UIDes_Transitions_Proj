using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class transition : MonoBehaviour
{
    public GameObject spriteObject; 

    public void FadeIn()
    {
        spriteObject.GetComponent<SpriteRenderer>().DOFade(1, 1f); 
    }

    public void FadeOut()
    {
        spriteObject.GetComponent<SpriteRenderer>().DOFade(0, 1f);
    }

    public void Bounce()
    {
        spriteObject.transform.DOJump(spriteObject.transform.position, 2f, 1, 1f); 
    }

    public void SlideLeft()
    {
        Vector3 originalPosition = spriteObject.transform.position;
        Sequence slideSequence = DOTween.Sequence();
        slideSequence.Append(spriteObject.transform.DOMoveX(originalPosition.x - 3, 1f)) 
            .AppendInterval(1f) 
            .Append(spriteObject.transform.DOMoveX(originalPosition.x, 1f)); 
    }

    public void Flip()
    {
        Sequence flipSequence = DOTween.Sequence();
        flipSequence.Append(spriteObject.transform.DORotate(new Vector3(0, 180, 0), 0.5f, RotateMode.FastBeyond360)) 
            .AppendInterval(1f) 
            .Append(spriteObject.transform.DORotate(new Vector3(0, 0, 0), 0.5f, RotateMode.FastBeyond360)); 
    }

    public void Rotate()
    {
        spriteObject.transform.DORotate(new Vector3(0, 0, 360), 1f, RotateMode.FastBeyond360); 
    }
}
