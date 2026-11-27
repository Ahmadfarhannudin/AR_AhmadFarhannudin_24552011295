using UnityEngine;

public class CenterModel : MonoBehaviour
{
    public Transform model;      // kosongkan = pakai child pertama
    public float tinggi = 0.01f; // jarak dasar model dari bidang target

    void Start()
    {
        if (model == null)
        {
            if (transform.childCount == 0) return;
            model = transform.GetChild(0);
        }

        bool ada = false;
        Bounds b = new Bounds();
        foreach (var mf in model.GetComponentsInChildren<MeshFilter>(true))
        {
            if (mf.sharedMesh == null) continue;
            Bounds lb = mf.sharedMesh.bounds;
            Vector3 c = lb.center, e = lb.extents;
            for (int i = 0; i < 8; i++)
            {
                Vector3 corner = c + new Vector3(
                    (i & 1) == 0 ? -e.x : e.x,
                    (i & 2) == 0 ? -e.y : e.y,
                    (i & 4) == 0 ? -e.z : e.z);
                Vector3 w = mf.transform.TransformPoint(corner);
                if (!ada) { b = new Bounds(w, Vector3.zero); ada = true; }
                else b.Encapsulate(w);
            }
        }
        if (!ada) return;

        Vector3 pusat = transform.position;
        Vector3 geser = new Vector3(
            b.center.x - pusat.x,
            b.min.y - pusat.y - tinggi,
            b.center.z - pusat.z);
        model.position -= geser;
    }
}