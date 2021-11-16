import api from "../APIcaller/API"
const content=document.getElementById("content");
const title=document.getElementById("title");

export default{
    displayAllAlbums,
    viewAddAlbum,
    SetupSaveButton
}

export function viewAddAlbum()
{
    title.innerText="Add Album";
    content.innerHTML =
    `
        <input type="text" value="" id="album_title" />
        <input type="text" value="" id="album_artist" />
        <input type="text" value="" id="album_image" />
        <input type="text" value="" id="album_recordLabel" />
    <button id="btnSaveAlbum">Save Album</button>
    `
    SetupSaveButton()

}


function displayAllAlbums()
{
    title.innerText="Albums";
    api.getRequest("https://localhost:44313/api/album", displayAlbums);

    function displayAlbums(data)
    {
        content.innerHTML =
        `
        <ol>
            ${data.map(album => "<li> Title: "+album.title+"</li>").join("")}
        </ol>
        <button id="btnAddAlbum">Add Album</button>
        `
        let btnAddAlbum = document.getElementById("btnAddAlbum");
        btnAddAlbum.addEventListener("click", viewAddAlbum

        );
    
    }

}

export function SetupSaveButton()
{
    let btnSave = document.getElementById("btnSaveAlbum");
    btnSave.addEventListener("click", function()
    {
        let albumTitle = document.getElementById("album_title").value;
        let albumArtist = document.getElementById("album_artist").value;
        let albumImage = document.getElementById("album_image").value;
        let albumRecordLabel = document.getElementById("album_recordLabel").value;

        const Album = {
            Title: albumTitle,
            Artist: albumArtist,
            Image: albumImage,
            RecordLabel: albumRecordLabel
        }
        api.postRequest("https://localhost:44313/api/album", Album, displayAllAlbums);
    });
}
