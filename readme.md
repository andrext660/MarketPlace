# MarketPlace
Este projeto simula uma API REST que realiza cadastro e compra de produtos. 
# Rotas
- Cadastrar um produto - [POST] - api/produtos
- Buscar Lista de produtos - [GET] - api/produtos
- Buscar produto por ID [POST] - api/produtos/**"ID do produto"**
- Deletar um produto por ID [DELETE] - api/produtos/**"ID do produto"**
- Cadastrar um cartão [POST] - api/cartao
- Realizar a compra de um produto [POST] - api/compras
- Realizar o pagamento de um produto[POST] - api/pagamento/compras
# Instruções
* É necessário realizar o cadastro de um produto inicialmente
- Após esse passo será necessário cadastrar um cartão de crédito
- Para concretizar a compra será preciso informar o id do produto, a quantidade comprada e o id do cartão.
- Como resultado será listado os dados do titular do cartão e o produto comprado com estoque atualizado.
- Para realizar o pagamento será necessario informar um valor de compra e o ID do cartão do Titular.
