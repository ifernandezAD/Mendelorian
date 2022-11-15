using UnityEngine;
using UnityEngine.SceneManagement;

public class MergePlayer : MonoBehaviour
{
    [SerializeField]
    string playerPhenotype;

    [SerializeField]
    string otherPhenotype;

    //Resulting genotype of the new pea
    [SerializeField]
    string genotype;

    //Player meshes
    [SerializeField]
    private MeshFilter currentModel;
    [SerializeField]
    private Mesh smoothModel;
    [SerializeField]
    private Mesh wrinkledModel;

    private void Awake()
    {
        playerPhenotype = "AB";
        genotype = "AABB";
    }

    private void OnCollisionEnter(Collision other)
    {
        var randomPhenotype = other.collider.GetComponent<RandomPhenotype>();
        if (randomPhenotype != null)
        {
            otherPhenotype = other.collider.GetComponent<RandomPhenotype>().phenotype;
            ObtainingGenotype();
            MixingPhenotypes();
            ChangeColor();
            ChangeMesh();
            Destroy(other.gameObject);
            WinningCheck();
        }
    }

    string ObtainingGenotype()
    {
        if (playerPhenotype == "AB" && otherPhenotype == "AB")
        {
            genotype = "AABB";
        }
        if (playerPhenotype == "AB" && otherPhenotype == "Ab")
        {
            genotype = "AABb";
        }
        if (playerPhenotype == "AB" && otherPhenotype == "aB")
        {
            genotype = "AaBB";
        }
        if (playerPhenotype == "AB" && otherPhenotype == "ab")
        {
            genotype = "AaBb";
        }


        if (playerPhenotype == "Ab" && otherPhenotype == "AB")
        {
            genotype = "AABb";
        }
        if (playerPhenotype == "Ab" && otherPhenotype == "Ab")
        {
            genotype = "AAbb";
        }
        if (playerPhenotype == "Ab" && otherPhenotype == "aB")
        {
            genotype = "AaBb";
        }
        if (playerPhenotype == "Ab" && otherPhenotype == "ab")
        {
            genotype = "Aabb";
        }


        if (playerPhenotype == "aB" && otherPhenotype == "AB")
        {
            genotype = "AaBB";
        }
        if (playerPhenotype == "aB" && otherPhenotype == "Ab")
        {
            genotype = "AaBb";
        }
        if (playerPhenotype == "aB" && otherPhenotype == "aB")
        {
            genotype = "aaBB";
        }
        if (playerPhenotype == "aB" && otherPhenotype == "ab")
        {
            genotype = "aaBb";
        }

        if (playerPhenotype == "ab" && otherPhenotype == "AB")
        {
            genotype = "AaBb";
        }
        if (playerPhenotype == "ab" && otherPhenotype == "Ab")
        {
            genotype = "Aabb";
        }
        if (playerPhenotype == "ab" && otherPhenotype == "aB")
        {
            genotype = "aaBb";
        }
        if (playerPhenotype == "ab" && otherPhenotype == "ab")
        {
            genotype = "aabb";
        }

        return genotype;
    }

    string MixingPhenotypes()
    {
        if (genotype == "AABB")
        {
            playerPhenotype = "AB";
        }

        if (genotype == "AaBB")
        {
            int pheno = Random.Range(0, 2);
            if (pheno == 0)
            {
                playerPhenotype = "AB";
            }
            else
            {
                playerPhenotype = "aB";
            }
        }

        if (genotype == "AABb")
        {
            int pheno = Random.Range(0, 2);
            if (pheno == 0)
            {
                playerPhenotype = "AB";
            }
            else
            {
                playerPhenotype = "Ab";
            }
        }

        if (genotype == "AaBb")
        {
            int pheno = Random.Range(0, 4);
            if (pheno == 0)
            {
                playerPhenotype = "AB";
            }
            if (pheno == 1)
            {
                playerPhenotype = "Ab";
            }
            if (pheno == 2)
            {
                playerPhenotype = "aB";
            }
            if (pheno == 3)
            {
                playerPhenotype = "ab";
            }
        }

        if (genotype == "AAbb")
        {
            playerPhenotype = "Ab";
        }

        if (genotype == "Aabb")
        {
            int pheno = Random.Range(0, 2);
            if (pheno == 0)
            {
                playerPhenotype = "Ab";
            }
            else
            {
                playerPhenotype = "ab";
            }
        }

        if (genotype == "aaBB")
        {
            playerPhenotype = "aB";
        }

        if (genotype == "aaBb")
        {
            int pheno = Random.Range(0, 2);
            if (pheno == 0)
            {
                playerPhenotype = "aB";
            }
            else
            {
                playerPhenotype = "ab";
            }
        }

        if (genotype == "aabb")
        {
            playerPhenotype = "ab";
        }

        return playerPhenotype;
    }

    void ChangeColor()
    {
        if (genotype == "AABB" || genotype == "AABb" || genotype == "AaBB" || genotype == "Aabb" || genotype == "AAbb" || genotype == "AaBb")
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }  
        
        if (genotype == "aaBb" || genotype == "aaBB"|| genotype == "aabb")
        {
            GetComponent<Renderer>().material.color = Color.green;
        }     
    }

    void ChangeMesh()
    {
        if (genotype == "AABB" || genotype == "AABb"|| genotype == "AaBb" || genotype == "aaBb" || genotype == "aaBB"|| genotype == "AaBB")
        {
            currentModel.mesh = smoothModel;
        }

        if (genotype == "AAbb" || genotype == "Aabb"|| genotype == "aabb")
        {
            currentModel.mesh = wrinkledModel;
        }
    }

    void WinningCheck()
    {
        if (genotype == "aabb")
        {
            SceneManager.LoadScene("Victory");
        }
    }
}