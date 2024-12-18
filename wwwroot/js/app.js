function createGame() {
    fetch('/api/game/create', { method: 'POST' })
        .then(response => response.json())
        .then(data => alert('Partie créée. ID: ' + data.GameId));
}

function joinGame() {
    const gameId = prompt('Entrez l\'ID de la partie :');
    const playerName = prompt('Entrez votre nom :');
    
    fetch(`/api/game/join/${gameId}`, {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ name: playerName })
    }).then(response => {
        if (response.ok) {
            alert('Vous avez rejoint la partie.');
        } else {
            alert('Impossible de rejoindre la partie.');
        }
    });
}