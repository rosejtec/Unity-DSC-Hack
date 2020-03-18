using UnityEngine;

public class Apple : MonoBehaviour
{
public Sprite sprite1;
public Sprite sprite2; 

 
 private SpriteRenderer spriteRenderer; 
 
 
 void Start ()
 {
     spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
     if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
         spriteRenderer.sprite = sprite1; // set the sprite to sprite1
 }
 
 void Update ()
 {
     
     if(Input.GetKeyDown (KeyCode.F))
     {
         ChangeTheSprite (); // call method to change sprite
     }
 }
 
 void ChangeTheSprite ()
 {
     if (spriteRenderer.sprite == sprite1) // if the spriteRenderer sprite = sprite1 then change to sprite2
     {
        spriteRenderer.sprite = sprite2;
        
          
     }
     else
     {
         spriteRenderer.sprite = sprite1; // otherwise change it back to sprite1
     }
 }
}
