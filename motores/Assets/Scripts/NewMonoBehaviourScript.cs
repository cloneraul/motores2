using UnityEngine;

public class SpawnerDeQuadrados : MonoBehaviour

{
	public GameObject quadradoPrefab;
	public float intervalo = 1f;
	private float tempoProximoSpawn;

 void Update()
 {
	if (Time.time >= tempoProximoSpawn)
	{
	SpawnarQuadrado();
	tempoProximoSpawn = Time.time + intervalo;
		}
	}

	void SpawnarQuadrado()
	{

// Define largura da tela
	float larguraTela = Camera.main.orthographicSize * Camera.main.aspect;
	float posX = Random.Range(-larguraTela, larguraTela);
	Vector2 posicaoSpawn = new Vector2(posX, Camera.main.orthographicSize + 1f);
	GameObject novoQuadrado = Instantiate(quadradoPrefab, posicaoSpawn, Quaternion.identity);
	}
}