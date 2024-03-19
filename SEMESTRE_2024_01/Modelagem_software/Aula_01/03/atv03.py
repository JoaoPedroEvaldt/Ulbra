class Voo:
    def __init__(self, companhiaAerea, origem, destino, dataPartida, precoPassagem):
        self.companhiaAerea = companhiaAerea
        self.origem = origem
        self.destino = destino
        self.dataPartida = dataPartida
        self.precoPassagem = precoPassagem

    def informacoesVoo(self):
        return f"Companhia Aérea: {self.companhiaAerea}\nOrigem: {self.origem}\nDestino: {self.destino}\nData de Partida: {self.dataPartida}\nPreço da Passagem: R${self.precoPassagem:.2f}"

voo1 = Voo("LATAM", "São Paulo", "Rio de Janeiro", "2024-04-15", 250.00)


