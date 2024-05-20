using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
   private int score;
   public Text scoretext;
   public GameObject pb;
   public GameObject go;
   public Player player;
   private void Awake()
   {
      Application.targetFrameRate=60;
      Pause();
   }
   public void Play()
   {
      score=0;
      scoretext.text=score.ToString();
      pb.SetActive(false);
      go.SetActive(false);
      Time.timeScale=1f;
      player.enabled=true;

      Pipe[] pipe=FindObjectsOfType<Pipe>();

      for(int i=0;i<pipe.Length;i++){
         Destroy(pipe[i].gameObject);
      }

   }
   public void Pause()
   {
      Time.timeScale=0f;
      player.enabled=false;
      Pipe[] pipe=FindObjectsOfType<Pipe>();

      for(int i=0;i<pipe.Length;i++){
         Destroy(pipe[i].gameObject);
      }

   }
   public void IncreaseScore()
   {
    score++;
    scoretext.text=score.ToString();
   }

   public void GameOver()
   {
      pb.SetActive(true);
      go.SetActive(true);
      Pause();

   }
}
