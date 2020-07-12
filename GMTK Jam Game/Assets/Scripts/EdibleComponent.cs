using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EdibleComponent : UsableComponent
{
    public UnityEvent onEat;

    public GameObject eatParticles;
    public Vector3 particleOffset;

    //TODO: Make this less bad
    private HungerBar hb;

    public float tolerence;
    public float value;
    public int uses = 1;
    public float eatDelay;

    private float lastEatTime;

    public void TryEat(float closeness)
    {
        if(closeness <= tolerence)
        {
            OnUse(null);
        }
    }

    private void Start()
    {
        hb = FindObjectOfType<HungerBar>();
        if (!hb)
        {
            Debug.LogError("No hunger bar found in scene!!");
        }
    }

    public override void OnUse(GameObject instigator)
    {
        if (Time.time - lastEatTime > eatDelay)
        {
            Debug.Log("NOM");

            if(eatParticles)
            {
                GameObject ep = Instantiate(eatParticles);
                ep.transform.position = transform.position;
                ep.transform.rotation = transform.rotation;

                ParticleSystem particles;
                if(ep.TryGetComponent(out particles))
                {
                    particles.Play();
                }
                else
                {
                    Debug.LogError("Eat particle object assigned doesn't even have a particle emitter. Like what..? Seriously?");
                }

                Destroy(ep, 5.0f);
            }

            lastEatTime = Time.time;

            uses--;

            //TODO: Make this not assume the player
            onEat.Invoke();
            hb.FillHunger();

            if (uses <= 0)
            {
                //TODO: Don't just delete this
                Destroy(gameObject);
            }
        }
    }
}
