using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameManager gameManager;
    public AudioSource overSound, Background, successSound;

    public ParticleSystem CollideParticle;
    public ParticleSystem collectableParticle;

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag== "obstacle")
        {
            gameManager.GameOver(); 
            Background.Pause();
            overSound.Play();
            //calling game over panel when player collides with obstacles
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "collectable")
        {
            var NewParticle4 = Instantiate(collectableParticle, transform.position, Quaternion.identity);
            NewParticle4.GetComponent<Renderer>().material = other.GetComponent<Renderer>().material;

        }


        switch (other.gameObject.tag)
        {
          

            case "cubeshape" :
            transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
                var NewParticle = Instantiate(CollideParticle, transform.position, Quaternion.identity);
                NewParticle.GetComponent<Renderer>().material = other.GetComponent<Renderer>().material;
            break;

            case "horrectangleshape" :
            transform.localScale = new Vector3(1.8f, 0.5f, 0.7f);
                var NewParticle1 = Instantiate(CollideParticle, transform.position, Quaternion.identity);
                NewParticle1.GetComponent<Renderer>().material = other.GetComponent<Renderer>().material;
                break;

            case "verrectangleshape" :
            transform.localScale = new Vector3(0.5f, 2, 0.5f);
                var NewParticle2 = Instantiate(CollideParticle, transform.position, Quaternion.identity);
                NewParticle2.GetComponent<Renderer>().material = other.GetComponent<Renderer>().material;
                break;

            case "capsule":
            transform.localScale = new Vector3(0.735362f, 0.716704f, 0.706597f);
            break;

            case "sphere":
            transform.localScale = new Vector3(0.5f, 2, 1);
            break;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name=="Success")
        {
            gameManager.GameSuccess();
            Background.Pause();
            overSound.Pause();
            successSound.Play();
            Destroy(gameObject);
        }
        
    }

    
}
