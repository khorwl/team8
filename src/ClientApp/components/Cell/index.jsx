import React from "react";
import styles from './styles.css'

export default class Cell extends React.Component {
    constructor(props) {
        super(props);
        this.id = props.id
    }

    render() {
        return (<td className={styles.cell} style={{backgroundImage: 'url("/images/card-joker.png")'}}>
            <div className={styles.card} id="demo">
                <div className={[styles.cardSide, styles.cardBack]}/>
                <div className={[styles.cardSide, styles.cardFace]}/>
            </div>
        </td>);
    }
}