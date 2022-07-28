// COMP30019 - Graphics and Interaction
// (c) University of Melbourne, 2022

using UnityEngine;

public class ChangeMeshOnCollision : MonoBehaviour
{
    //This allows you to choose which mesh (shape) you want it to the object to turn into in Inspector
    [SerializeField] private Mesh cubeModel; 

    private void OnCollisionEnter()
    {
        // You can change the mesh of an object through its MeshFilter
        // Get the MeshFilter of the object
        var currentModel = GetComponent<MeshFilter>();

        // Change the current mesh of the MeshFilter into the mesh you chose in the Inspector
        currentModel.mesh = cubeModel;
    }
}
