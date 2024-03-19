class Praia:
    def __init__(self, nome, localizacao, temperaturaAgua, tipoAreia):
        self.nome = nome
        self.localizacao = localizacao
        self.temperaturaAgua = temperaturaAgua
        self.tipoAreia = tipoAreia

    def informacoesPraia(self):
        return f"Nome: {self.nome}\nLocalização: {self.localizacao}\nTemperatura da água: {self.temperaturaAgua}°C\nTipo de areia: {self.tipoAreia}"


praia1 = Praia("Copacabana", "Rio de Janeiro, Brasil", 25, "Fina")


print(praia1.informacoesPraia())
