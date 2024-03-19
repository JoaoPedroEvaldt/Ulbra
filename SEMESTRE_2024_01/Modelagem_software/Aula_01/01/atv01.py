class Aluno:
    def __init__(self, nome, matricula, idade, curso):
        self.nome = nome
        self.matricula = matricula
        self.idade = idade
        self.curso = curso

    def mostrarInformacoes(self):
        return f"Nome: {self.nome}\nMatrícula: {self.matricula}\nIdade: {self.idade}\nCurso: {self.curso}"


aluno1 = Aluno("João", "12345", 20, "Engenharia Civil")


print(aluno1.mostrarInformacoes())
