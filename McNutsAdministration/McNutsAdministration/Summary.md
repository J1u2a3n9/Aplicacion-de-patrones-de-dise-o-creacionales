MCNuts Administrators 
Los administradores de mcNuts quieren usar una sola instancia en su sistema de control de creacion de sabores de mani y las funciones CRUD sobre la lista de administradores por lo cual se uso el patron de diseño creacional
threadSafeSingleton no solo para controlar lo antes dicho si no tambien para evitar problemas con la concurrencia dado que se usa mucho el sistema, asi mismo la gran variedad de saboores nuevos de mani llevo a la decision
de los administradores de poder utilizar el patron FactoryMethod dado que es un patron que permite aumentar demasiado en funcionalidad y variedad de sabores al emprendimiento lo cual es necesario a futuro para poder ampli
ar la gama y funcionalidades que se ofrece a los clientes
