using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class SpawnBubbles : MonoBehaviour
{
    [SerializeField]
    private GameObject bubblePrefab;

    [SerializeField]
    private Color[] bubbleColors;

    [SerializeField]
    private int timeInterval;//enter in seconds should maybe decrease a little as time goes by to a min.

    private Timer timer;
    private float bubbleX = 0;
    private float bubbleMax = .1f;
    private float bubbleMin = -8.5f;
    private float bubbleY;
    private Color bubbleColor;
    private List<GameObject> bubbles;
    private GameObject currentBubble;

	void Start ()
    {
        bubbleY = transform.position.y;
        bubbles = new List<GameObject>();
        StartCoroutine(Spawn());
	}

    IEnumerator Spawn()
    {
        while (GeneralGameKnowledge.gameOver == false)//while the game is still going, keep spawning the bubbles
        {        //set a posision for bubble
            bubbleX = FindRandomPosition();
            //spawn a new bubble
            currentBubble = Instantiate(bubblePrefab, new Vector2(bubbleX, bubbleY), new Quaternion(0, 0, 0, 0));//quat is rotation
            currentBubble.GetComponent<SpriteRenderer>().color = FindBubbleColor();
            bubbles.Add(currentBubble);//add my bubble to a bubble list;;;
            yield return new WaitForSeconds(timeInterval);
        }
    }

    float FindRandomPosition()
    {
        return Random.Range(bubbleMin, bubbleMax);
    }

    Color FindBubbleColor()
    {
        return bubbleColors[Random.Range(0, bubbleColors.Length)];//random color from array
    }

}
