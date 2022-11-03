using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPhenotype : MonoBehaviour
{
    public string phenotype;

    private void Awake()
    {
        MixingPhenotypes();   
    }

    string MixingPhenotypes()
    {
        if (gameObject.tag == "AABB")
        {
            phenotype = "AB";
        }

        if (gameObject.tag == "AaBB")
        {
            int pheno = Random.Range(0, 2);
            if (pheno == 0)
            {
                phenotype = "AB";
            }
            else
            {
                phenotype = "aB";
            }
        }

        if (gameObject.tag == "AABb")
        {
            int pheno = Random.Range(0, 2);
            if (pheno == 0)
            {
                phenotype = "AB";
            }
            else
            {
                phenotype = "Ab";
            }
        }

        if (gameObject.tag == "AaBb")
        {
            int pheno = Random.Range(0, 4);
            if (pheno == 0)
            {
                phenotype = "AB";
            }
            if (pheno == 1)
            {
                phenotype = "Ab";
            }
            if (pheno == 2)
            {
                phenotype = "aB";
            }
            if (pheno == 3)
            {
                phenotype = "ab";
            }
        }

        if (gameObject.tag == "AAbb")
        {
            phenotype = "Ab";
        }

        if (gameObject.tag == "Aabb")
        {
            int pheno = Random.Range(0, 2);
            if (pheno == 0)
            {
                phenotype = "Ab";
            }
            else
            {
                phenotype = "ab";
            }
        }

        if (gameObject.tag == "aaBB")
        {
            phenotype = "aB";
        }

        if (gameObject.tag == "aaBb")
        {
            int pheno = Random.Range(0, 2);
            if (pheno == 0)
            {
                phenotype = "aB";
            }
            else
            {
                phenotype = "ab";
            }
        }

        if (gameObject.tag == "aabb")
        {
            phenotype = "ab";
        }

        return phenotype;
    }   
}
