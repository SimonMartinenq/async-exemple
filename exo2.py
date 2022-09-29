import time
import asyncio

def serveur():
    cuisinier('Burger',1)
    cuisinier('Salade César',1)
    cuisinier('Côte de boeuf',3)


async def serveur_async():
    task1 = asyncio.create_task(cuisinier_async('Burger',5))
    task2 = asyncio.create_task(cuisinier_async('Salade César',1))
    task3 = asyncio.create_task(cuisinier_async('Côte de boeuf',3))
    await task1
    await task2
    await task3

async def cuisinier_async(order, time_to_prepare):
    print(f'Nouvelle commande: {order}')
    await asyncio.sleep(time_to_prepare)
    print(order, '- prêt !')

def cuisinier(order, time_to_prepare):
    print(f'Nouvelle commande: {order}')
    time.sleep(time_to_prepare)
    print(order, '- prêt !')

if __name__ == '__main__':
    """ serveur() """
    asyncio.run(serveur_async())