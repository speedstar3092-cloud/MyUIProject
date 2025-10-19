using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;

public class RandomPassword : MonoBehaviour
{
    [Header("DOTween Animation 컴포넌트들")]
    [SerializeField] private DOTweenAnimation[] numberAnimations = new DOTweenAnimation[4];
    
    
    public void RandomizeNumbers()
    {
        for (int i = 0; i < numberAnimations.Length; i++)
        {
            if (numberAnimations[i] != null)
            {
                // 0~9 사이의 랜덤 숫자 생성
                int randomNumber = Random.Range(0, 10);

                // DOTween Animation의 endValueString에 값 설정
                numberAnimations[i].endValueString = randomNumber.ToString();
                
                numberAnimations[i].RecreateTween();
            }
        }
    }

}