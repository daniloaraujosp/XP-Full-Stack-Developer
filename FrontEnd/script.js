const alunos = [
    {
        nome: "Pablo",
        idade: 25,
    },
    {
        nome: "José",
        idade: 19,
    },
    {
        nome: "Roberto",
        idade: 16,
    },
];


const alunosFiltrados = alunos.filter(aluno => aluno.idade >= 18)
console.table(alunosFiltrados);


const alunoRoberto = alunos.find(aluno => aluno.nome == 'Roberto')
console.log(alunoRoberto);


const alunoRobertoIndex = alunos.findIndex(aluno => aluno.nome == 'Roberto')
console.log(alunoRobertoIndex);


const idades = alunos.reduce((acc, aluno) => {
    return acc + aluno.idade
}, 0);
console.log(idades);


const acimaDeNove = alunos.some(alunos => alunos.idade < 10);
const menorQueNoventa = alunos.some(alunos => alunos.idade < 90);

console.log(acimaDeNove);
console.log(menorQueNoventa);

