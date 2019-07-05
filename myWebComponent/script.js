class infoBtn extends HTMLElement {
    constructor() {
        super();
    }

    connectedCallback () {
        this.innerHTML = `
        <div>
            <button>+ info</button>
        </div>
        `
    }
}

window.customElements.define('info-button', infoBtn);