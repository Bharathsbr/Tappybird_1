using UnityEngine;

public class Player : MonoBehaviour
{
    private SpriteRenderer sr;
    public Sprite[] sprites;
    private int spriteIndex;
    private Vector3 direction;
    private Vector3 rd;
    public float gravity=-9.8f;
    public float strength=5f;

    private void Awake(){
        sr=GetComponent<SpriteRenderer>();
        rd=transform.position;
    }

    private void Start()
    {
        InvokeRepeating(nameof(AnimateSprite),0.15f,0.15f);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            direction=Vector3.up * strength;
        }

        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }

    private void AnimateSprite()
    {
        spriteIndex++;
        if(spriteIndex>=sprites.Length){
            spriteIndex=0;
        }
        sr.sprite=sprites[spriteIndex];
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Obstacle"){
            FindObjectOfType<GameManager>().GameOver();
            transform.position=rd;
        }else if(other.gameObject.tag=="Score"){
            FindObjectOfType<GameManager>().IncreaseScore();
        }
    }
}
 