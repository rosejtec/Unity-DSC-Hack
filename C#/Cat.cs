
using UnityEngine;

public class Cat : MonoBehaviour
{
   
private float _timeSittingAround;

public AudioSource pianoNote;

private void OnMouseDown()
    {
        pianoNote = GetComponent<AudioSource>();
        pianoNote.Play();
        GetComponent<SpriteRenderer>().color = Color.blue;
      
    }

    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
        
    }


 
  void Update() 
  {
      _timeSittingAround += Time.deltaTime;
  
    if(_timeSittingAround < 2 || _timeSittingAround > 550)
        transform.Translate(Time.deltaTime*5*-Vector3.right);

      
    if(transform.position.x > 10 )
            Destroy(gameObject);

      
  
 }
}