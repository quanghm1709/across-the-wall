using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGcontroller : MonoBehaviour
{
    public Vector3 scaleIncreaseRate; // Tốc độ tăng tỷ lệ
    public float scaleDuration; // Thời gian tăng tỷ lệ

    private Vector3 initialScale;
    private float elapsedTime;

    public List<GameObject> pose;
    public int currentPose;

    public playerController player;
    public GameManager gm;

    private void Start()
    {
        initialScale = transform.localScale;
        elapsedTime = 0f;
    }

    private void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime <= scaleDuration)
        {
            // Tính toán tỷ lệ mới dựa trên tốc độ tăng tỷ lệ và thời gian đã trôi qua
            Vector3 newScale = initialScale + scaleIncreaseRate * (elapsedTime / scaleDuration);
            transform.localScale = newScale;
		}
		else
		{
            if(player.currentPose == currentPose)
			{
                if (!gm.lose.activeInHierarchy)
                    gm.win.SetActive(true);
			}
			else
			{
                if(!gm.win.activeInHierarchy)
                gm.lose.SetActive(true);
			}
            Time.timeScale = 0;
		}
    }
}
