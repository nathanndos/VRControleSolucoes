# Instalação do SQL EXPRESS

Para colocar a aplicação para produção é simples, baixa seguir os passos abaixo.

1) Baixar o SQL EXPRESS 2014 32bit ou 64bit. Obs.: versões anteriores ou posteriores não são compatíveis
2) Após baixado, abra o executável
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



