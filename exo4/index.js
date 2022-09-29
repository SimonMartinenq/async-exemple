const apiKey = "5883392a77214b549c023c215f4b54d3"

const buttonRecherche = document.getElementById("submitRecipe")

const block = document.getElementById("infos");

const getRecipe = async (recipe) => {
    let reponse  = await fetch(`https://api.spoonacular.com/recipes/complexSearch?apiKey=${apiKey}&query=${recipe}"&number=1`)
    let recipes = await reponse.json();
    return recipes;
}
   

buttonRecherche.onclick = () => {
    let ingr = document.getElementById("recipe").value
    if(ingr.length < 1){
        alert("Enter something")
    }else{
        console.log("recette avec : "+ingr)
        getRecipe(ingr)
        .then((data)=>{
            if (data.results.length<1) {
                alert("No results")
            }else{
                const img = document.createElement("img");
                const titre = document.createElement("h1")
                img.src = data.results[0].image;
                titre.textContent = data.results[0].title
                block.innerHTML=""
                block.appendChild(img);
                block.appendChild(titre);
            }
        })
    }
    
}
