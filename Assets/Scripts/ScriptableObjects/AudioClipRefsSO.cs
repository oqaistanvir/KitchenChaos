using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class AudioClipRefsSO : ScriptableObject
{
    [SerializeField] private AudioClip[] chop;
    [SerializeField] private AudioClip[] deliveryFail;
    [SerializeField] private AudioClip[] deliverySuccess;
    [SerializeField] private AudioClip[] footstep;
    [SerializeField] private AudioClip[] objectDrop;
    [SerializeField] private AudioClip[] objectPickUp;
    [SerializeField] private AudioClip panSizzle;
    [SerializeField] private AudioClip[] trash;
    [SerializeField] private AudioClip[] warning;

    public AudioClip[] GetChopAudioClip()
    {
        return chop;
    }

    public AudioClip[] GetDeliveryFailAudioClip()
    {
        return deliveryFail;
    }

    public AudioClip[] GetDeliverySuccessAudioClip()
    {
        return deliverySuccess;
    }

    public AudioClip[] GetFootstepAudioClip()
    {
        return footstep;
    }

    public AudioClip[] GetObjectDropAudioClip()
    {
        return objectDrop;
    }

    public AudioClip[] GetObjectPickUpAudioClip()
    {
        return objectPickUp;
    }

    public AudioClip GetStoveSizzleAudioClip()
    {
        return panSizzle;
    }

    public AudioClip[] GetTrashAudioClip()
    {
        return trash;
    }

    public AudioClip[] GetWarningAudioClip()
    {
        return warning;
    }
}
