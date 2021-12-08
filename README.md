# Instalação .NET Framework
1) Acesso o link https://dotnet.microsoft.com/download/dotnet-framework/net472
2) Faça download do .Net RUNTIME

# Instalação do SQL EXPRESS

Para colocar a aplicação para produção é simples, baixa seguir os passos abaixo.

1) Acesse o link https://www.microsoft.com/pt-br/download/details.aspx?id=42299
2) Marque a opção Express 64BIT\SQLEXPR_x64_PTB.exe ou Express 32BIT\SQLEXPR_x86_PTB.exe, para baixar o SQL EXPRESS 2014 32bit ou 64bit. 
	Obs.: versões anteriores ou posteriores não são compatíveis
4) Após baixado, abra o executável
	1) Clique em "Nova instalação autônoma do SQL SERVER...."
	2) Aceite os termos da licença. Obs.: Não é necessário marcar a segunda opção
	3) Não marque a opção "Usar o Microsoft Update para procurar atualizações"
	4) Nas próximas duas telas é necessário somente dar "avançar"
	5) Em "configuração de instância", marque "instância nomeada" e coloque "SQL2014".
	6) Na aba "Configuração do Mecanismo de Banco de dados", marque a opção "Modo misto" e coloque a senha como "senha".
	7) Com todos os passos seguidos corretamente é só esperar a mensagem de sucesso e finalizar.

# Baixando e preparando a aplicação

Baixe este projeto e descompacte normalmente. Dentro da nova pasta, há outro arquivo compactado chamado "VRControleSolucao". Descompacte o novo arquivo na pasta raiz do computador.

Obs.: Garanta que o caminho da pasta descompactada seja "C:\VRControleSolucao", caso contrário, não irá funcionar
1) Dentro da pasta, há dois arquivos de banco de dados, são eles: "vrsolucoes" e "vrsolucoes_log". As ações abaixo devem ser realizadas em ambos:
	1) Clique com o botão direito, depois propriedades
	2) Clique em segurança, depois editar
	3) Na nova janela aberta, clique em adicionar, digite "todos", dê "OK" e selecione "todos" novamente. 
	4) Selecione "todos" na divisão de "Nome de grupo ou de usuário" e dê permissão de "controle total" na divisão "Permissão para...."
2) Execute o "LigarBase" e clique em "Iniciar".
3) Caso, o feedback seja positivo, não será mais necessário utilizar o "LigarBase novamente. Sendo assim é só executar o "VRControleSolucao" e começar a usar normalmente


# Funcionamento do programa
1) Na tela principal no campo "pesquisa"
	1) Quando estiver com a opção "nome" estiver marcada for pressionada a tecla Enter, será utilizada a função do botao "buscar", ou seja ele irá filtrar as informações 	referentes aos nomes das soluções
	2) Quando estiver com 'codigo' marcado, o botao 'visualizar' será habilitado, ao apertar Enter será utilizada a função de visualização, abrindo a janela com as informações do codigo principal digitado. Caso seja selecionado o botão de "buscar", ele irá filtrar a busca pelo código exato da pesquisa
- Os atalhos só funcionam com o foco no campo da pesquisa

NOVA SOLUÇÂO
Quando clicar vai abrir uma nova janela
- Nome do problema. Poderia ser por exemplo "erro 451 da nfce
- Na descrição voce vai colocar o passo a passo de como arrumou ou o comando
- Ai tem os botoes de ação em baixo, o proprio nome ja deixa claro oq é

ATUALIZAR
Quando voltar, pra aparecer na pesquisa é só apertar em atualizar
Pra abrir as informações que estão no grid é só dar dois cliques nas palavras ou codigos
