using System.Collections;
using UnityEngine;
public class Coin : MonoBehaviour
{
    private float bonusTime = 2f;
    private float disappearTime = 5f;
    private int bonusScoreValue = 20;
    private bool isBonus = true;
    private int scoreValue = 10;
    void Start()
    {
        StartCoroutine(BonusTimeCoroutine());
    }
    IEnumerator BonusTimeCoroutine()
    {
        // ここまではボーナスタイムの2秒待つ
        yield return new WaitForSeconds(bonusTime);
        isBonus = false;
        // 消える時間は5秒なので、ボーナスタイムを2秒消費した3秒待つ
        yield return new WaitForSeconds(disappearTime - bonusTime);
        Destroy(this.gameObject);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Sphere")
        {
            if (isBonus)
            {
                Scoremanager.ScoreCount += bonusScoreValue;
            }
            else
            {
                Scoremanager.ScoreCount += scoreValue;
            }
            Destroy(gameObject);
        }
    }
}

